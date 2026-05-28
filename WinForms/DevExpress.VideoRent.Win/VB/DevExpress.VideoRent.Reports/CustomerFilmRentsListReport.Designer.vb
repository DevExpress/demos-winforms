Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Reports
	Partial Public Class CustomerFilmRentsListReport
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
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabelCustomerFullName = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrPictureBoxCustomerPhoto = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrTableFilmsColumnHeaders = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRowColumnHeaders = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellPhotoColumnHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellFilmInfoColumnHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellRentStartDateColumnHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellExpectedOnColumnHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellRentEndDateColumnHeader = New DevExpress.XtraReports.UI.XRTableCell()
			Me.topMarginBand = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfoPageCount = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.DetailReportReceipts = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.DetailFilmInfo = New DevExpress.XtraReports.UI.DetailBand()
			Me.DetailReportRents = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.DetailRents = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTableFilms = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRowFilmInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellPhoto = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrPictureBoxPhoto = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrTableCellTitle = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableMovieInfo = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRowMovieTitle = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellMovieTitle = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowMovieFormat = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellMovieFormat = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowPlot = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellPlot = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellRentedOn = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellExpectedOn = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellReturnedOn = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xpCollectionCustomers = New DevExpress.Xpo.XPCollection()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrLabelHeader = New DevExpress.XtraReports.UI.XRLabel()
			Me.showModeParameter = New DevExpress.XtraReports.Parameters.Parameter()
			CType(Me.xrTableFilmsColumnHeaders, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTableFilms, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTableMovieInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabelCustomerFullName, Me.xrPictureBoxCustomerPhoto, Me.xrTableFilmsColumnHeaders})
			Me.Detail.HeightF = 204.9999F
			Me.Detail.KeepTogether = True
			Me.Detail.KeepTogetherWithDetailReports = True
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabelCustomerFullName
			' 
			Me.xrLabelCustomerFullName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FullNameLastSorting"), New DevExpress.XtraReports.UI.XRBinding("Bookmark", Nothing, "FullNameLastSorting")})
			Me.xrLabelCustomerFullName.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11F)
			Me.xrLabelCustomerFullName.LocationFloat = New DevExpress.Utils.PointFloat(87.5F, 140F)
			Me.xrLabelCustomerFullName.Name = "xrLabelCustomerFullName"
			Me.xrLabelCustomerFullName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabelCustomerFullName.SizeF = New System.Drawing.SizeF(515.5834F, 20.00003F)
			Me.xrLabelCustomerFullName.StylePriority.UseFont = False
			Me.xrLabelCustomerFullName.StylePriority.UseTextAlignment = False
			Me.xrLabelCustomerFullName.Text = "xrLabelCustomerFullName"
			Me.xrLabelCustomerFullName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xrPictureBoxCustomerPhoto
			' 
			Me.xrPictureBoxCustomerPhoto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Photo")})
			Me.xrPictureBoxCustomerPhoto.LocationFloat = New DevExpress.Utils.PointFloat(300F, 12.5F)
			Me.xrPictureBoxCustomerPhoto.Name = "xrPictureBoxCustomerPhoto"
			Me.xrPictureBoxCustomerPhoto.SizeF = New System.Drawing.SizeF(105F, 125F)
			Me.xrPictureBoxCustomerPhoto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
'			Me.xrPictureBoxCustomerPhoto.BeforePrint += New DevExpress.XtraReports.UI.BeforePrintEventHandler(Me.xrPictureBoxCustomerPhoto_BeforePrint);
			' 
			' xrTableFilmsColumnHeaders
			' 
			Me.xrTableFilmsColumnHeaders.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
			Me.xrTableFilmsColumnHeaders.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(225))))))
			Me.xrTableFilmsColumnHeaders.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(160))))), (CInt(Fix((CByte(172))))), (CInt(Fix((CByte(182))))))
			Me.xrTableFilmsColumnHeaders.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableFilmsColumnHeaders.Font = New DevExpress.Drawing.DXFont("Times New Roman", 9.75F)
			Me.xrTableFilmsColumnHeaders.KeepTogether = True
			Me.xrTableFilmsColumnHeaders.LocationFloat = New DevExpress.Utils.PointFloat(0F, 174.9999F)
			Me.xrTableFilmsColumnHeaders.Name = "xrTableFilmsColumnHeaders"
			Me.xrTableFilmsColumnHeaders.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowColumnHeaders})
			Me.xrTableFilmsColumnHeaders.SizeF = New System.Drawing.SizeF(700F, 30F)
			Me.xrTableFilmsColumnHeaders.StylePriority.UseBackColor = False
			Me.xrTableFilmsColumnHeaders.StylePriority.UseBorderColor = False
			Me.xrTableFilmsColumnHeaders.StylePriority.UseBorders = False
			Me.xrTableFilmsColumnHeaders.StylePriority.UseFont = False
			' 
			' xrTableRowColumnHeaders
			' 
			Me.xrTableRowColumnHeaders.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellPhotoColumnHeader, Me.xrTableCellFilmInfoColumnHeader, Me.xrTableCellRentStartDateColumnHeader, Me.xrTableCellExpectedOnColumnHeader, Me.xrTableCellRentEndDateColumnHeader})
			Me.xrTableRowColumnHeaders.Name = "xrTableRowColumnHeaders"
			Me.xrTableRowColumnHeaders.Weight = 1
			' 
			' xrTableCellPhotoColumnHeader
			' 
			Me.xrTableCellPhotoColumnHeader.CanGrow = False
			Me.xrTableCellPhotoColumnHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrTableCellPhotoColumnHeader.Name = "xrTableCellPhotoColumnHeader"
			Me.xrTableCellPhotoColumnHeader.StylePriority.UseFont = False
			Me.xrTableCellPhotoColumnHeader.StylePriority.UseTextAlignment = False
			Me.xrTableCellPhotoColumnHeader.Text = "Cover"
			Me.xrTableCellPhotoColumnHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellPhotoColumnHeader.Weight = 0.52294987794682846
			' 
			' xrTableCellFilmInfoColumnHeader
			' 
			Me.xrTableCellFilmInfoColumnHeader.CanGrow = False
			Me.xrTableCellFilmInfoColumnHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrTableCellFilmInfoColumnHeader.Name = "xrTableCellFilmInfoColumnHeader"
			Me.xrTableCellFilmInfoColumnHeader.StylePriority.UseFont = False
			Me.xrTableCellFilmInfoColumnHeader.StylePriority.UseTextAlignment = False
			Me.xrTableCellFilmInfoColumnHeader.Text = "Film Info"
			Me.xrTableCellFilmInfoColumnHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellFilmInfoColumnHeader.Weight = 1.5688500924089377
			' 
			' xrTableCellRentStartDateColumnHeader
			' 
			Me.xrTableCellRentStartDateColumnHeader.CanGrow = False
			Me.xrTableCellRentStartDateColumnHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrTableCellRentStartDateColumnHeader.Name = "xrTableCellRentStartDateColumnHeader"
			Me.xrTableCellRentStartDateColumnHeader.StylePriority.UseFont = False
			Me.xrTableCellRentStartDateColumnHeader.StylePriority.UseTextAlignment = False
			Me.xrTableCellRentStartDateColumnHeader.Text = "Rented on"
			Me.xrTableCellRentStartDateColumnHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellRentStartDateColumnHeader.Weight = 0.52294970561954968
			' 
			' xrTableCellExpectedOnColumnHeader
			' 
			Me.xrTableCellExpectedOnColumnHeader.CanGrow = False
			Me.xrTableCellExpectedOnColumnHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrTableCellExpectedOnColumnHeader.Name = "xrTableCellExpectedOnColumnHeader"
			Me.xrTableCellExpectedOnColumnHeader.StylePriority.UseFont = False
			Me.xrTableCellExpectedOnColumnHeader.StylePriority.UseTextAlignment = False
			Me.xrTableCellExpectedOnColumnHeader.Text = "Expected on"
			Me.xrTableCellExpectedOnColumnHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellExpectedOnColumnHeader.Weight = 0.52294986247842823
			' 
			' xrTableCellRentEndDateColumnHeader
			' 
			Me.xrTableCellRentEndDateColumnHeader.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellRentEndDateColumnHeader.CanGrow = False
			Me.xrTableCellRentEndDateColumnHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrTableCellRentEndDateColumnHeader.Name = "xrTableCellRentEndDateColumnHeader"
			Me.xrTableCellRentEndDateColumnHeader.StylePriority.UseBorders = False
			Me.xrTableCellRentEndDateColumnHeader.StylePriority.UseFont = False
			Me.xrTableCellRentEndDateColumnHeader.StylePriority.UseTextAlignment = False
			Me.xrTableCellRentEndDateColumnHeader.Text = "Returned on"
			Me.xrTableCellRentEndDateColumnHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellRentEndDateColumnHeader.Weight = 0.52294914954506977
			' 
			' topMarginBand
			' 
			Me.topMarginBand.HeightF = 50F
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
			Me.xrPageInfoPageCount.LocationFloat = New DevExpress.Utils.PointFloat(600.0001F, 0F)
			Me.xrPageInfoPageCount.Name = "xrPageInfoPageCount"
			Me.xrPageInfoPageCount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfoPageCount.SizeF = New System.Drawing.SizeF(99.99994F, 23.00002F)
			Me.xrPageInfoPageCount.StylePriority.UseFont = False
			Me.xrPageInfoPageCount.StylePriority.UseTextAlignment = False
			Me.xrPageInfoPageCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' DetailReportReceipts
			' 
			Me.DetailReportReceipts.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.DetailFilmInfo, Me.DetailReportRents})
			Me.DetailReportReceipts.DataMember = "Receipts"
			Me.DetailReportReceipts.DataSource = Me.xpCollectionCustomers
			Me.DetailReportReceipts.Level = 0
			Me.DetailReportReceipts.Name = "DetailReportReceipts"
			' 
			' DetailFilmInfo
			' 
			Me.DetailFilmInfo.HeightF = 0F
			Me.DetailFilmInfo.Name = "DetailFilmInfo"
			' 
			' DetailReportRents
			' 
			Me.DetailReportRents.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.DetailRents})
			Me.DetailReportRents.DataMember = "Receipts.Rents"
			Me.DetailReportRents.DataSource = Me.xpCollectionCustomers
			Me.DetailReportRents.Level = 0
			Me.DetailReportRents.Name = "DetailReportRents"
            Me.DetailReportRents.ReportPrintOptions.PrintOnEmptyDataSource = False
			' 
			' DetailRents
			' 
			Me.DetailRents.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTableFilms})
			Me.DetailRents.HeightF = 140F
			Me.DetailRents.Name = "DetailRents"
			' 
			' xrTableFilms
			' 
			Me.xrTableFilms.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableFilms.KeepTogether = True
			Me.xrTableFilms.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTableFilms.Name = "xrTableFilms"
			Me.xrTableFilms.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowFilmInfo})
			Me.xrTableFilms.SizeF = New System.Drawing.SizeF(700F, 140F)
			Me.xrTableFilms.StylePriority.UseBorders = False
			' 
			' xrTableRowFilmInfo
			' 
			Me.xrTableRowFilmInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellPhoto, Me.xrTableCellTitle, Me.xrTableCellRentedOn, Me.xrTableCellExpectedOn, Me.xrTableCellReturnedOn})
			Me.xrTableRowFilmInfo.Name = "xrTableRowFilmInfo"
			Me.xrTableRowFilmInfo.Weight = 1
			' 
			' xrTableCellPhoto
			' 
			Me.xrTableCellPhoto.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellPhoto.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPictureBoxPhoto})
			Me.xrTableCellPhoto.Font = New DevExpress.Drawing.DXFont("Calibri", 12F)
			Me.xrTableCellPhoto.Name = "xrTableCellPhoto"
			Me.xrTableCellPhoto.StylePriority.UseBorders = False
			Me.xrTableCellPhoto.StylePriority.UseFont = False
			Me.xrTableCellPhoto.StylePriority.UseTextAlignment = False
			Me.xrTableCellPhoto.Text = "xrTableCellPhoto"
			Me.xrTableCellPhoto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellPhoto.Weight = 0.42895799503931054
			' 
			' xrPictureBoxPhoto
			' 
			Me.xrPictureBoxPhoto.BackColor = System.Drawing.Color.White
			Me.xrPictureBoxPhoto.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(219))))))
			Me.xrPictureBoxPhoto.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrPictureBoxPhoto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Receipts.Rents.MoviePhoto")})
			Me.xrPictureBoxPhoto.LocationFloat = New DevExpress.Utils.PointFloat(1.589457E-05F, 0F)
			Me.xrPictureBoxPhoto.Name = "xrPictureBoxPhoto"
			Me.xrPictureBoxPhoto.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 1, 1, 100F)
			Me.xrPictureBoxPhoto.SizeF = New System.Drawing.SizeF(100F, 140F)
			Me.xrPictureBoxPhoto.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
			Me.xrPictureBoxPhoto.StylePriority.UseBackColor = False
			Me.xrPictureBoxPhoto.StylePriority.UseBorderColor = False
			Me.xrPictureBoxPhoto.StylePriority.UseBorders = False
			Me.xrPictureBoxPhoto.StylePriority.UsePadding = False
'			Me.xrPictureBoxPhoto.BeforePrint += New DevExpress.XtraReports.UI.BeforePrintEventHandler(Me.xrPictureBoxPhoto_BeforePrint);
			' 
			' xrTableCellTitle
			' 
			Me.xrTableCellTitle.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCellTitle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTableMovieInfo})
			Me.xrTableCellTitle.Font = New DevExpress.Drawing.DXFont("Verdana", 9.75F)
			Me.xrTableCellTitle.Multiline = True
			Me.xrTableCellTitle.Name = "xrTableCellTitle"
			Me.xrTableCellTitle.StylePriority.UseBorders = False
			Me.xrTableCellTitle.StylePriority.UseFont = False
			Me.xrTableCellTitle.StylePriority.UseTextAlignment = False
			Me.xrTableCellTitle.Text = "xrTableCellTitle"
			Me.xrTableCellTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellTitle.Weight = 1.2868742439987364
			' 
			' xrTableMovieInfo
			' 
			Me.xrTableMovieInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableMovieInfo.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTableMovieInfo.Name = "xrTableMovieInfo"
			Me.xrTableMovieInfo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowMovieTitle, Me.xrTableRowMovieFormat, Me.xrTableRowPlot})
			Me.xrTableMovieInfo.SizeF = New System.Drawing.SizeF(300.0001F, 140F)
			Me.xrTableMovieInfo.StylePriority.UseBorders = False
			' 
			' xrTableRowMovieTitle
			' 
			Me.xrTableRowMovieTitle.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellMovieTitle})
			Me.xrTableRowMovieTitle.Name = "xrTableRowMovieTitle"
			Me.xrTableRowMovieTitle.Weight = 0.43916619757478564
			' 
			' xrTableCellMovieTitle
			' 
			Me.xrTableCellMovieTitle.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(233))))), (CInt(Fix((CByte(235))))))
			Me.xrTableCellMovieTitle.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(219))))))
			Me.xrTableCellMovieTitle.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellMovieTitle.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Receipts.Rents.MovieTitle")})
			Me.xrTableCellMovieTitle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.75F)
			Me.xrTableCellMovieTitle.Name = "xrTableCellMovieTitle"
			Me.xrTableCellMovieTitle.StylePriority.UseBackColor = False
			Me.xrTableCellMovieTitle.StylePriority.UseBorderColor = False
			Me.xrTableCellMovieTitle.StylePriority.UseBorders = False
			Me.xrTableCellMovieTitle.StylePriority.UseFont = False
			Me.xrTableCellMovieTitle.Text = "xrTableCellMovieTitle"
			Me.xrTableCellMovieTitle.Weight = 2.5568376159667969
			' 
			' xrTableRowMovieFormat
			' 
			Me.xrTableRowMovieFormat.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellMovieFormat})
			Me.xrTableRowMovieFormat.Name = "xrTableRowMovieFormat"
			Me.xrTableRowMovieFormat.Weight = 0.4391661975747857
			' 
			' xrTableCellMovieFormat
			' 
			Me.xrTableCellMovieFormat.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(245))))), (CInt(Fix((CByte(247))))), (CInt(Fix((CByte(246))))))
			Me.xrTableCellMovieFormat.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(219))))))
			Me.xrTableCellMovieFormat.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellMovieFormat.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Receipts.Rents.ItemFormat")})
			Me.xrTableCellMovieFormat.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9.75F)
			Me.xrTableCellMovieFormat.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(93))))), (CInt(Fix((CByte(97))))), (CInt(Fix((CByte(98))))))
			Me.xrTableCellMovieFormat.Name = "xrTableCellMovieFormat"
			Me.xrTableCellMovieFormat.StylePriority.UseBackColor = False
			Me.xrTableCellMovieFormat.StylePriority.UseBorderColor = False
			Me.xrTableCellMovieFormat.StylePriority.UseBorders = False
			Me.xrTableCellMovieFormat.StylePriority.UseFont = False
			Me.xrTableCellMovieFormat.StylePriority.UseForeColor = False
			Me.xrTableCellMovieFormat.Text = "xrTableCellMovieFormat"
			Me.xrTableCellMovieFormat.Weight = 2.5568376159667969
			' 
			' xrTableRowPlot
			' 
			Me.xrTableRowPlot.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellPlot})
			Me.xrTableRowPlot.Name = "xrTableRowPlot"
			Me.xrTableRowPlot.Weight = 1.5809977466414493
			' 
			' xrTableCellPlot
			' 
			Me.xrTableCellPlot.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(245))))), (CInt(Fix((CByte(247))))), (CInt(Fix((CByte(246))))))
			Me.xrTableCellPlot.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(219))))))
			Me.xrTableCellPlot.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellPlot.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Receipts.Rents.MoviePlot")})
			Me.xrTableCellPlot.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellPlot.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(93))))), (CInt(Fix((CByte(97))))), (CInt(Fix((CByte(98))))))
			Me.xrTableCellPlot.Name = "xrTableCellPlot"
			Me.xrTableCellPlot.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F)
			Me.xrTableCellPlot.StylePriority.UseBackColor = False
			Me.xrTableCellPlot.StylePriority.UseBorderColor = False
			Me.xrTableCellPlot.StylePriority.UseBorders = False
			Me.xrTableCellPlot.StylePriority.UseFont = False
			Me.xrTableCellPlot.StylePriority.UseForeColor = False
			Me.xrTableCellPlot.StylePriority.UsePadding = False
			Me.xrTableCellPlot.StylePriority.UseTextAlignment = False
			Me.xrTableCellPlot.Text = "xrTableCellPlot"
			Me.xrTableCellPlot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
			Me.xrTableCellPlot.Weight = 2.5568376159667969
			' 
			' xrTableCellRentedOn
			' 
			Me.xrTableCellRentedOn.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(245))))), (CInt(Fix((CByte(247))))), (CInt(Fix((CByte(246))))))
			Me.xrTableCellRentedOn.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(219))))))
			Me.xrTableCellRentedOn.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellRentedOn.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Receipts.Rents.RentedOn", "{0:d}")})
			Me.xrTableCellRentedOn.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellRentedOn.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(93))))), (CInt(Fix((CByte(97))))), (CInt(Fix((CByte(98))))))
			Me.xrTableCellRentedOn.Multiline = True
			Me.xrTableCellRentedOn.Name = "xrTableCellRentedOn"
			Me.xrTableCellRentedOn.StylePriority.UseBackColor = False
			Me.xrTableCellRentedOn.StylePriority.UseBorderColor = False
			Me.xrTableCellRentedOn.StylePriority.UseBorders = False
			Me.xrTableCellRentedOn.StylePriority.UseFont = False
			Me.xrTableCellRentedOn.StylePriority.UseForeColor = False
			Me.xrTableCellRentedOn.StylePriority.UseTextAlignment = False
			Me.xrTableCellRentedOn.Text = "xrTableCellRentedOn"
			Me.xrTableCellRentedOn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellRentedOn.Weight = 0.42895799100693155
			' 
			' xrTableCellExpectedOn
			' 
			Me.xrTableCellExpectedOn.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(245))))), (CInt(Fix((CByte(247))))), (CInt(Fix((CByte(246))))))
			Me.xrTableCellExpectedOn.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(219))))))
			Me.xrTableCellExpectedOn.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Receipts.Rents.ClearedReturnedOnDate", "{0:d}")})
			Me.xrTableCellExpectedOn.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellExpectedOn.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(93))))), (CInt(Fix((CByte(97))))), (CInt(Fix((CByte(98))))))
			Me.xrTableCellExpectedOn.Multiline = True
			Me.xrTableCellExpectedOn.Name = "xrTableCellExpectedOn"
			Me.xrTableCellExpectedOn.StylePriority.UseBackColor = False
			Me.xrTableCellExpectedOn.StylePriority.UseBorderColor = False
			Me.xrTableCellExpectedOn.StylePriority.UseFont = False
			Me.xrTableCellExpectedOn.StylePriority.UseForeColor = False
			Me.xrTableCellExpectedOn.StylePriority.UseTextAlignment = False
			Me.xrTableCellExpectedOn.Text = "[Rents.ClearedReturnedOnDate]"
			Me.xrTableCellExpectedOn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellExpectedOn.Weight = 0.42895800935788148
			' 
			' xrTableCellReturnedOn
			' 
			Me.xrTableCellReturnedOn.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(233))))), (CInt(Fix((CByte(235))))))
			Me.xrTableCellReturnedOn.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(217))))), (CInt(Fix((CByte(219))))))
			Me.xrTableCellReturnedOn.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Receipts.Rents.ReturnedOn", "{0:d}")})
			Me.xrTableCellReturnedOn.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellReturnedOn.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(93))))), (CInt(Fix((CByte(97))))), (CInt(Fix((CByte(98))))))
			Me.xrTableCellReturnedOn.Multiline = True
			Me.xrTableCellReturnedOn.Name = "xrTableCellReturnedOn"
			Me.xrTableCellReturnedOn.StylePriority.UseBackColor = False
			Me.xrTableCellReturnedOn.StylePriority.UseBorderColor = False
			Me.xrTableCellReturnedOn.StylePriority.UseFont = False
			Me.xrTableCellReturnedOn.StylePriority.UseForeColor = False
			Me.xrTableCellReturnedOn.StylePriority.UseTextAlignment = False
			Me.xrTableCellReturnedOn.Text = "xrTableCellRentEndDate"
			Me.xrTableCellReturnedOn.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellReturnedOn.Weight = 0.42895777772454391
'			Me.xrTableCellReturnedOn.BeforePrint += New DevExpress.XtraReports.UI.BeforePrintEventHandler(Me.xrTableCellReturnedOn_BeforePrint);
			' 
			' xpCollectionCustomers
			' 
			Me.xpCollectionCustomers.CaseSensitive = True
			Me.xpCollectionCustomers.ObjectType = GetType(DevExpress.VideoRent.Customer)
			Me.xpCollectionCustomers.Sorting.AddRange(New DevExpress.Xpo.SortProperty() { New DevExpress.Xpo.SortProperty("[FullNameLastSorting]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
'			Me.xpCollectionCustomers.ResolveSession += New DevExpress.Xpo.ResolveSessionEventHandler(Me.xpCollectionCustomers_ResolveSession);
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabelHeader})
			Me.ReportHeader.HeightF = 35F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrLabelHeader
			' 
			Me.xrLabelHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 16F)
			Me.xrLabelHeader.LocationFloat = New DevExpress.Utils.PointFloat(212.5F, 0F)
			Me.xrLabelHeader.Name = "xrLabelHeader"
			Me.xrLabelHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabelHeader.SizeF = New System.Drawing.SizeF(287.5F, 35F)
			Me.xrLabelHeader.StylePriority.UseFont = False
			Me.xrLabelHeader.StylePriority.UseTextAlignment = False
			Me.xrLabelHeader.Text = "Movie Rentals by Customer"
			Me.xrLabelHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' showModeParameter
			' 
			Me.showModeParameter.Description = "Details:"
			Me.showModeParameter.Name = "showModeParameter"
			Me.showModeParameter.Value = ""
			' 
			' CustomerFilmRentsListReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand, Me.bottomMarginBand, Me.DetailReportReceipts, Me.ReportHeader})
			Me.Bookmark = "Customers"
			Me.DataSource = Me.xpCollectionCustomers
			Me.Margins = New DevExpress.Drawing.DXMargins(75, 75, 50, 50)
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.showModeParameter})
			Me.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.Version = "10.2"
			CType(Me.xrTableFilmsColumnHeaders, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTableFilms, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTableMovieInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionCustomers, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private topMarginBand As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand As DevExpress.XtraReports.UI.BottomMarginBand
		Private DetailReportReceipts As DevExpress.XtraReports.UI.DetailReportBand
		Private DetailFilmInfo As DevExpress.XtraReports.UI.DetailBand
		Private WithEvents xpCollectionCustomers As DevExpress.Xpo.XPCollection
		Private xrPageInfoPageCount As DevExpress.XtraReports.UI.XRPageInfo
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabelHeader As DevExpress.XtraReports.UI.XRLabel
		Private xrLabelCustomerFullName As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents xrPictureBoxCustomerPhoto As DevExpress.XtraReports.UI.XRPictureBox
		Private xrTableFilmsColumnHeaders As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowColumnHeaders As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellPhotoColumnHeader As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellFilmInfoColumnHeader As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellRentStartDateColumnHeader As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellRentEndDateColumnHeader As DevExpress.XtraReports.UI.XRTableCell
		Private DetailReportRents As DevExpress.XtraReports.UI.DetailReportBand
		Private DetailRents As DevExpress.XtraReports.UI.DetailBand
		Private xrTableFilms As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowFilmInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellPhoto As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xrPictureBoxPhoto As DevExpress.XtraReports.UI.XRPictureBox
		Private xrTableCellTitle As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellRentedOn As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xrTableCellReturnedOn As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellExpectedOnColumnHeader As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellExpectedOn As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableMovieInfo As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowMovieTitle As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellMovieTitle As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowPlot As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellPlot As DevExpress.XtraReports.UI.XRTableCell
		Private showModeParameter As DevExpress.XtraReports.Parameters.Parameter
		Private xrTableRowMovieFormat As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellMovieFormat As DevExpress.XtraReports.UI.XRTableCell
	End Class
End Namespace
