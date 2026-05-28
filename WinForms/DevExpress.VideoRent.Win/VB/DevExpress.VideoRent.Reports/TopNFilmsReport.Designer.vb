Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Reports
	Partial Public Class TopNFilmsReport
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
			Me.xrTableTopFilmInfo = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRowMovieTitle = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellMovieTitle = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowFilmInfo = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellFilmInfo = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableFilmInfo = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRowReleaseDate = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellReleaseDateLabel = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellReleaseDate = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowPlot = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellPlotLabel = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCellPlot = New DevExpress.XtraReports.UI.XRTableCell()
			Me.topMarginBand = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPageInfoPageCount = New DevExpress.XtraReports.UI.XRPageInfo()
			Me.calculatedFieldRentsCount = New DevExpress.XtraReports.UI.CalculatedField()
			Me.xpCollectionMovies = New DevExpress.Xpo.XPCollection()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrHeader = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle()
			Me.xrPictureBoxCover = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.xrTableCellRentsCount = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowRentsCount = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCellRentsCountLabel = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableRowRentsCountLabel = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableRentsCount = New DevExpress.XtraReports.UI.XRTable()
			CType(Me.xrTableTopFilmInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTableFilmInfo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollectionMovies, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTableRentsCount, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTableRentsCount, Me.xrPictureBoxCover, Me.xrTableTopFilmInfo})
			Me.Detail.HeightF = 170F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("calculatedFieldRentsCount", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrTableTopFilmInfo
			' 
			Me.xrTableTopFilmInfo.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(159))))), (CInt(Fix((CByte(159))))), (CInt(Fix((CByte(139))))))
			Me.xrTableTopFilmInfo.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableTopFilmInfo.BorderWidth = 1
			Me.xrTableTopFilmInfo.Font = New DevExpress.Drawing.DXFont("Verdana", 8.25F)
			Me.xrTableTopFilmInfo.KeepTogether = True
			Me.xrTableTopFilmInfo.LocationFloat = New DevExpress.Utils.PointFloat(0F, 5F)
			Me.xrTableTopFilmInfo.Name = "xrTableTopFilmInfo"
			Me.xrTableTopFilmInfo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowMovieTitle, Me.xrTableRowFilmInfo})
			Me.xrTableTopFilmInfo.SizeF = New System.Drawing.SizeF(650F, 160F)
			Me.xrTableTopFilmInfo.StylePriority.UseBorderColor = False
			Me.xrTableTopFilmInfo.StylePriority.UseBorders = False
			Me.xrTableTopFilmInfo.StylePriority.UseBorderWidth = False
			Me.xrTableTopFilmInfo.StylePriority.UseFont = False
			Me.xrTableTopFilmInfo.StylePriority.UseTextAlignment = False
			Me.xrTableTopFilmInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xrTableRowMovieTitle
			' 
			Me.xrTableRowMovieTitle.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellMovieTitle})
			Me.xrTableRowMovieTitle.Name = "xrTableRowMovieTitle"
			Me.xrTableRowMovieTitle.Weight = 0.43749999904632575
			' 
			' xrTableCellMovieTitle
			' 
			Me.xrTableCellMovieTitle.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(195))))), (CInt(Fix((CByte(197))))), (CInt(Fix((CByte(114))))))
			Me.xrTableCellMovieTitle.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellMovieTitle.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Title")})
			Me.xrTableCellMovieTitle.Font = New DevExpress.Drawing.DXFont("Segoe UI", 11.25F)
			Me.xrTableCellMovieTitle.Multiline = True
			Me.xrTableCellMovieTitle.Name = "xrTableCellMovieTitle"
			Me.xrTableCellMovieTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(136, 0, 0, 0, 100F)
			Me.xrTableCellMovieTitle.StylePriority.UseBackColor = False
			Me.xrTableCellMovieTitle.StylePriority.UseBorders = False
			Me.xrTableCellMovieTitle.StylePriority.UseFont = False
			Me.xrTableCellMovieTitle.StylePriority.UsePadding = False
			Me.xrTableCellMovieTitle.StylePriority.UseTextAlignment = False
			Me.xrTableCellMovieTitle.Text = "[Title]"
			Me.xrTableCellMovieTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellMovieTitle.Weight = 4.2162157014543444
			' 
			' xrTableRowFilmInfo
			' 
			Me.xrTableRowFilmInfo.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellFilmInfo})
			Me.xrTableRowFilmInfo.Name = "xrTableRowFilmInfo"
			Me.xrTableRowFilmInfo.Weight = 1.5625000009536745
			' 
			' xrTableCellFilmInfo
			' 
			Me.xrTableCellFilmInfo.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(230))))), (CInt(Fix((CByte(206))))))
			Me.xrTableCellFilmInfo.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTableFilmInfo})
			Me.xrTableCellFilmInfo.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellFilmInfo.Name = "xrTableCellFilmInfo"
			Me.xrTableCellFilmInfo.StylePriority.UseBackColor = False
			Me.xrTableCellFilmInfo.StylePriority.UseFont = False
			Me.xrTableCellFilmInfo.Text = "xrTableCellFilmInfo"
			Me.xrTableCellFilmInfo.Weight = 4.2162157014543444
			' 
			' xrTableFilmInfo
			' 
			Me.xrTableFilmInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableFilmInfo.LocationFloat = New DevExpress.Utils.PointFloat(135F, 14.99999F)
			Me.xrTableFilmInfo.Name = "xrTableFilmInfo"
			Me.xrTableFilmInfo.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowReleaseDate, Me.xrTableRowPlot})
			Me.xrTableFilmInfo.SizeF = New System.Drawing.SizeF(380F, 95F)
			Me.xrTableFilmInfo.StylePriority.UseBorders = False
			' 
			' xrTableRowReleaseDate
			' 
			Me.xrTableRowReleaseDate.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellReleaseDateLabel, Me.xrTableCellReleaseDate})
			Me.xrTableRowReleaseDate.Name = "xrTableRowReleaseDate"
			Me.xrTableRowReleaseDate.Weight = 1
			' 
			' xrTableCellReleaseDateLabel
			' 
			Me.xrTableCellReleaseDateLabel.CanGrow = False
			Me.xrTableCellReleaseDateLabel.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellReleaseDateLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(113))))), (CInt(Fix((CByte(110))))), (CInt(Fix((CByte(99))))))
			Me.xrTableCellReleaseDateLabel.Name = "xrTableCellReleaseDateLabel"
			Me.xrTableCellReleaseDateLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F)
			Me.xrTableCellReleaseDateLabel.StylePriority.UseFont = False
			Me.xrTableCellReleaseDateLabel.StylePriority.UseForeColor = False
			Me.xrTableCellReleaseDateLabel.StylePriority.UsePadding = False
			Me.xrTableCellReleaseDateLabel.StylePriority.UseTextAlignment = False
			Me.xrTableCellReleaseDateLabel.Text = "Date:"
			Me.xrTableCellReleaseDateLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellReleaseDateLabel.Weight = 0.58768033539163955
			' 
			' xrTableCellReleaseDate
			' 
			Me.xrTableCellReleaseDate.CanGrow = False
			Me.xrTableCellReleaseDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ReleaseDate", "{0:d}")})
			Me.xrTableCellReleaseDate.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellReleaseDate.Name = "xrTableCellReleaseDate"
			Me.xrTableCellReleaseDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 0, 1, 100F)
			Me.xrTableCellReleaseDate.StylePriority.UseFont = False
			Me.xrTableCellReleaseDate.StylePriority.UsePadding = False
			Me.xrTableCellReleaseDate.StylePriority.UseTextAlignment = False
			Me.xrTableCellReleaseDate.Text = "xrTableCellReleaseDate"
			Me.xrTableCellReleaseDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrTableCellReleaseDate.Weight = 2.4123196646083604
			' 
			' xrTableRowPlot
			' 
			Me.xrTableRowPlot.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellPlotLabel, Me.xrTableCellPlot})
			Me.xrTableRowPlot.Name = "xrTableRowPlot"
			Me.xrTableRowPlot.Weight = 2.4000006713868212
			' 
			' xrTableCellPlotLabel
			' 
			Me.xrTableCellPlotLabel.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellPlotLabel.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(113))))), (CInt(Fix((CByte(110))))), (CInt(Fix((CByte(99))))))
			Me.xrTableCellPlotLabel.Name = "xrTableCellPlotLabel"
			Me.xrTableCellPlotLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 0, 0, 0, 100F)
			Me.xrTableCellPlotLabel.StylePriority.UseFont = False
			Me.xrTableCellPlotLabel.StylePriority.UseForeColor = False
			Me.xrTableCellPlotLabel.StylePriority.UsePadding = False
			Me.xrTableCellPlotLabel.StylePriority.UseTextAlignment = False
			Me.xrTableCellPlotLabel.Text = "Synopsis:"
			Me.xrTableCellPlotLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCellPlotLabel.Weight = 0.58768033539163955
			' 
			' xrTableCellPlot
			' 
			Me.xrTableCellPlot.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Plot")})
			Me.xrTableCellPlot.Font = New DevExpress.Drawing.DXFont("Segoe UI", 8.25F)
			Me.xrTableCellPlot.Name = "xrTableCellPlot"
			Me.xrTableCellPlot.Padding = New DevExpress.XtraPrinting.PaddingInfo(1, 1, 0, 1, 100F)
			Me.xrTableCellPlot.StylePriority.UseFont = False
			Me.xrTableCellPlot.StylePriority.UsePadding = False
			Me.xrTableCellPlot.StylePriority.UseTextAlignment = False
			Me.xrTableCellPlot.Text = "xrTableCellPlot"
			Me.xrTableCellPlot.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			Me.xrTableCellPlot.Weight = 2.4123196646083604
			' 
			' topMarginBand
			' 
			Me.topMarginBand.Font = New DevExpress.Drawing.DXFont("Segoe UI Semibold", 14.25F, DevExpress.Drawing.DXFontStyle.Bold)
			Me.topMarginBand.HeightF = 50F
			Me.topMarginBand.Name = "topMarginBand"
			Me.topMarginBand.StylePriority.UseFont = False
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
			Me.xrPageInfoPageCount.LocationFloat = New DevExpress.Utils.PointFloat(533.1005F, 0F)
			Me.xrPageInfoPageCount.Name = "xrPageInfoPageCount"
			Me.xrPageInfoPageCount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrPageInfoPageCount.SizeF = New System.Drawing.SizeF(116.8995F, 23.00002F)
			Me.xrPageInfoPageCount.StylePriority.UseFont = False
			Me.xrPageInfoPageCount.StylePriority.UseTextAlignment = False
			Me.xrPageInfoPageCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight
			' 
			' calculatedFieldRentsCount
			' 
			Me.calculatedFieldRentsCount.DataSource = Me.xpCollectionMovies
			Me.calculatedFieldRentsCount.Name = "calculatedFieldRentsCount"
'			Me.calculatedFieldRentsCount.GetValue += New DevExpress.XtraReports.UI.GetValueEventHandler(Me.calculatedFieldRentsCount_GetValue);
			' 
			' xpCollectionMovies
			' 
			Me.xpCollectionMovies.CaseSensitive = True
			Me.xpCollectionMovies.ObjectType = GetType(DevExpress.VideoRent.Movie)
'			Me.xpCollectionMovies.ResolveSession += New DevExpress.Xpo.ResolveSessionEventHandler(Me.xpCollectionMovies_ResolveSession);
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrHeader})
			Me.ReportHeader.HeightF = 35F
			Me.ReportHeader.Name = "ReportHeader"
			Me.ReportHeader.StylePriority.UseTextAlignment = False
			Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xrHeader
			' 
			Me.xrHeader.AutoWidth = True
			Me.xrHeader.Font = New DevExpress.Drawing.DXFont("Segoe UI", 16F)
			Me.xrHeader.LocationFloat = New DevExpress.Utils.PointFloat(237.5F, 0F)
			Me.xrHeader.Name = "xrHeader"
			Me.xrHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrHeader.SizeF = New System.Drawing.SizeF(186.4582F, 35F)
			Me.xrHeader.StyleName = "xrControlStyle1"
			Me.xrHeader.StylePriority.UseFont = False
			Me.xrHeader.StylePriority.UseTextAlignment = False
			Me.xrHeader.Text = "Top Movie Rentals"
			Me.xrHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			' 
			' xrControlStyle1
			' 
			Me.xrControlStyle1.Name = "xrControlStyle1"
			Me.xrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			' 
			' xrPictureBoxCover
			' 
			Me.xrPictureBoxCover.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Photo")})
			Me.xrPictureBoxCover.LocationFloat = New DevExpress.Utils.PointFloat(15F, 20F)
			Me.xrPictureBoxCover.Name = "xrPictureBoxCover"
			Me.xrPictureBoxCover.SizeF = New System.Drawing.SizeF(105F, 130F)
			Me.xrPictureBoxCover.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
'			Me.xrPictureBoxCover.BeforePrint += New DevExpress.XtraReports.UI.BeforePrintEventHandler(Me.xrPictureBoxCover_BeforePrint);
			' 
			' xrTableCellRentsCount
			' 
			Me.xrTableCellRentsCount.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellRentsCount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "calculatedFieldRentsCount")})
			Me.xrTableCellRentsCount.Font = New DevExpress.Drawing.DXFont("Segoe UI", 27.75F)
			Me.xrTableCellRentsCount.Name = "xrTableCellRentsCount"
			Me.xrTableCellRentsCount.StylePriority.UseBorders = False
			Me.xrTableCellRentsCount.StylePriority.UseFont = False
			Me.xrTableCellRentsCount.StylePriority.UseTextAlignment = False
			Me.xrTableCellRentsCount.Text = "xrTableCellRentsCount"
			Me.xrTableCellRentsCount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellRentsCount.Weight = 2.0208334350585937
			' 
			' xrTableRowRentsCount
			' 
			Me.xrTableRowRentsCount.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellRentsCount})
			Me.xrTableRowRentsCount.Name = "xrTableRowRentsCount"
			Me.xrTableRowRentsCount.Weight = 1.6153846153846154
			' 
			' xrTableCellRentsCountLabel
			' 
			Me.xrTableCellRentsCountLabel.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCellRentsCountLabel.Font = New DevExpress.Drawing.DXFont("Segoe UI", 9F)
			Me.xrTableCellRentsCountLabel.Name = "xrTableCellRentsCountLabel"
			Me.xrTableCellRentsCountLabel.StylePriority.UseBorders = False
			Me.xrTableCellRentsCountLabel.StylePriority.UseFont = False
			Me.xrTableCellRentsCountLabel.StylePriority.UseTextAlignment = False
			Me.xrTableCellRentsCountLabel.Text = "Rental Count"
			Me.xrTableCellRentsCountLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCellRentsCountLabel.Weight = 2.0208334350585937
			' 
			' xrTableRowRentsCountLabel
			' 
			Me.xrTableRowRentsCountLabel.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCellRentsCountLabel})
			Me.xrTableRowRentsCountLabel.Name = "xrTableRowRentsCountLabel"
			Me.xrTableRowRentsCountLabel.Weight = 0.38461538461538469
			' 
			' xrTableRentsCount
			' 
			Me.xrTableRentsCount.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(245))))), (CInt(Fix((CByte(240))))), (CInt(Fix((CByte(226))))))
			Me.xrTableRentsCount.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(159))))), (CInt(Fix((CByte(159))))), (CInt(Fix((CByte(139))))))
			Me.xrTableRentsCount.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableRentsCount.LocationFloat = New DevExpress.Utils.PointFloat(530F, 20.00001F)
			Me.xrTableRentsCount.Name = "xrTableRentsCount"
			Me.xrTableRentsCount.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRowRentsCountLabel, Me.xrTableRowRentsCount})
			Me.xrTableRentsCount.SizeF = New System.Drawing.SizeF(105F, 130F)
			Me.xrTableRentsCount.StylePriority.UseBackColor = False
			Me.xrTableRentsCount.StylePriority.UseBorderColor = False
			Me.xrTableRentsCount.StylePriority.UseBorders = False
			' 
			' TopNFilmsReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand, Me.bottomMarginBand, Me.ReportHeader})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.calculatedFieldRentsCount})
			Me.DataSource = Me.xpCollectionMovies
			Me.Extensions.Add("ParametersRequestExtension", "TimePeriodReport")
			Me.Extensions.Add("DataSerializationExtension", "TimePeriodReport")
			Me.Extensions.Add("DataEditorExtension", "TimePeriodReport")
			Me.Extensions.Add("ParameterEditorExtension", "TimePeriodReport")
			Me.Margins = New DevExpress.Drawing.DXMargins(100, 100, 50, 50)
            Me.ReportPrintOptions.PrintOnEmptyDataSource = False
			Me.RequestParameters = False
			Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.xrControlStyle1})
			Me.Version = "10.2"
'			Me.BeforePrint += New DevExpress.XtraReports.UI.BeforePrintEventHandler(Me.TopNFilmsReport_BeforePrint);
			CType(Me.xrTableTopFilmInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTableFilmInfo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollectionMovies, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTableRentsCount, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private topMarginBand As DevExpress.XtraReports.UI.TopMarginBand
		Private bottomMarginBand As DevExpress.XtraReports.UI.BottomMarginBand
		Private WithEvents xpCollectionMovies As DevExpress.Xpo.XPCollection
		Private WithEvents calculatedFieldRentsCount As DevExpress.XtraReports.UI.CalculatedField
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrHeader As DevExpress.XtraReports.UI.XRLabel
		Private xrPageInfoPageCount As DevExpress.XtraReports.UI.XRPageInfo
		Private xrTableTopFilmInfo As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowMovieTitle As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellMovieTitle As DevExpress.XtraReports.UI.XRTableCell
		Private xrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
		Private xrTableRowFilmInfo As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellFilmInfo As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableFilmInfo As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowReleaseDate As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellReleaseDateLabel As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellReleaseDate As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowPlot As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellPlotLabel As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCellPlot As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRentsCount As DevExpress.XtraReports.UI.XRTable
		Private xrTableRowRentsCountLabel As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellRentsCountLabel As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableRowRentsCount As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCellRentsCount As DevExpress.XtraReports.UI.XRTableCell
		Private WithEvents xrPictureBoxCover As DevExpress.XtraReports.UI.XRPictureBox
	End Class
End Namespace
