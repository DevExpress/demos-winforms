Imports Microsoft.VisualBasic
Imports System
Namespace DevExpress.VideoRent.Win.Reports
	Partial Public Class LatefeeReceipt
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
			Dim xrSummary2 As New DevExpress.XtraReports.UI.XRSummary()
			Dim xrSummary3 As New DevExpress.XtraReports.UI.XRSummary()
			Dim xrSummary4 As New DevExpress.XtraReports.UI.XRSummary()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.detailBand1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrlCustomerPhone = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrlCustomerAddress = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrlCustomerName = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrlDate = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrlReceiptNumber = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
			Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
			Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
			Me.xpRents = New DevExpress.Xpo.XPCollection()
			Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrlPayment = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrlDiscount = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpRents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' topMarginBand1
			' 
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' detailBand1
			' 
			Me.detailBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable1})
			Me.detailBand1.HeightF = 25F
			Me.detailBand1.Name = "detailBand1"
			' 
			' xrTable1
			' 
			Me.xrTable1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(160))))), (CInt(Fix((CByte(172))))), (CInt(Fix((CByte(182))))))
			Me.xrTable1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable1.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 9.75F)
			Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrTable1.Name = "xrTable1"
			Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1})
			Me.xrTable1.SizeF = New System.Drawing.SizeF(640F, 25F)
			Me.xrTable1.StylePriority.UseBorderColor = False
			Me.xrTable1.StylePriority.UseBorderDashStyle = False
			Me.xrTable1.StylePriority.UseBorders = False
			Me.xrTable1.StylePriority.UseFont = False
			Me.xrTable1.StylePriority.UseTextAlignment = False
			Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrTableRow1
			' 
			Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3, Me.xrTableCell4, Me.xrTableCell5})
			Me.xrTableRow1.Name = "xrTableRow1"
			Me.xrTableRow1.Weight = 1
			' 
			' xrTableCell1
			' 
			Me.xrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RentId")})
			Me.xrTableCell1.Name = "xrTableCell1"
			Me.xrTableCell1.StylePriority.UseBorders = False
			Me.xrTableCell1.StylePriority.UseTextAlignment = False
			xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
			xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.xrTableCell1.Summary = xrSummary1
			Me.xrTableCell1.Text = "xrTableCell1"
			Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell1.Weight = 0.12980771533130683
			' 
			' xrTableCell2
			' 
			Me.xrTableCell2.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "RentId", "{0:d8}")})
			Me.xrTableCell2.Name = "xrTableCell2"
			Me.xrTableCell2.StylePriority.UseBorderColor = False
			Me.xrTableCell2.StylePriority.UseBorders = False
			Me.xrTableCell2.StylePriority.UseTextAlignment = False
			Me.xrTableCell2.Text = "xrTableCell2"
			Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell2.Weight = 0.36057717091936131
			' 
			' xrTableCell3
			' 
			Me.xrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MovieInfo")})
			Me.xrTableCell3.Name = "xrTableCell3"
			Me.xrTableCell3.StylePriority.UseBorders = False
			Me.xrTableCell3.Text = "xrTableCell3"
			Me.xrTableCell3.Weight = 1.4158652281902391
			' 
			' xrTableCell4
			' 
			Me.xrTableCell4.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
			Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Overdue")})
			Me.xrTableCell4.Name = "xrTableCell4"
			Me.xrTableCell4.StylePriority.UseBorders = False
			Me.xrTableCell4.StylePriority.UseTextAlignment = False
			Me.xrTableCell4.Text = "xrTableCell4"
			Me.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell4.Weight = 0.4483175003457876
			' 
			' xrTableCell5
			' 
			Me.xrTableCell5.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OverduePayment", "{0:c}")})
			Me.xrTableCell5.Name = "xrTableCell5"
			Me.xrTableCell5.StylePriority.UseBorders = False
			Me.xrTableCell5.StylePriority.UseTextAlignment = False
			Me.xrTableCell5.Text = "xrTableCell5"
			Me.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrTableCell5.Weight = 0.59927812084235188
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrlCustomerPhone, Me.xrlCustomerAddress, Me.xrlCustomerName, Me.xrLabel4, Me.xrlDate, Me.xrLabel1, Me.xrlReceiptNumber, Me.xrTable2})
			Me.ReportHeader.HeightF = 138.9583F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrlCustomerPhone
			' 
			Me.xrlCustomerPhone.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 11.25F)
			Me.xrlCustomerPhone.LocationFloat = New DevExpress.Utils.PointFloat(106.2501F, 84.16666F)
			Me.xrlCustomerPhone.Name = "xrlCustomerPhone"
			Me.xrlCustomerPhone.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrlCustomerPhone.SizeF = New System.Drawing.SizeF(533.7499F, 21.24999F)
			Me.xrlCustomerPhone.StylePriority.UseFont = False
			Me.xrlCustomerPhone.Text = "Phone"
			' 
			' xrlCustomerAddress
			' 
			Me.xrlCustomerAddress.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 11.25F)
			Me.xrlCustomerAddress.LocationFloat = New DevExpress.Utils.PointFloat(106.2501F, 62.91666F)
			Me.xrlCustomerAddress.Name = "xrlCustomerAddress"
			Me.xrlCustomerAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrlCustomerAddress.SizeF = New System.Drawing.SizeF(533.7499F, 21.24999F)
			Me.xrlCustomerAddress.StylePriority.UseFont = False
			Me.xrlCustomerAddress.Text = "Address"
			' 
			' xrlCustomerName
			' 
			Me.xrlCustomerName.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 11.25F)
			Me.xrlCustomerName.LocationFloat = New DevExpress.Utils.PointFloat(106.2501F, 41.66667F)
			Me.xrlCustomerName.Name = "xrlCustomerName"
			Me.xrlCustomerName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrlCustomerName.SizeF = New System.Drawing.SizeF(533.7499F, 21.24999F)
			Me.xrlCustomerName.StylePriority.UseFont = False
			Me.xrlCustomerName.Text = "Name"
			' 
			' xrLabel4
			' 
			Me.xrLabel4.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 11.25F)
			Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(28.12502F, 41.66667F)
			Me.xrLabel4.Name = "xrLabel4"
			Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel4.SizeF = New System.Drawing.SizeF(78.12506F, 21.24999F)
			Me.xrLabel4.StylePriority.UseFont = False
			Me.xrLabel4.Text = "Customer:"
			' 
			' xrlDate
			' 
			Me.xrlDate.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 11.25F)
			Me.xrlDate.LocationFloat = New DevExpress.Utils.PointFloat(402.0834F, 3.999996F)
			Me.xrlDate.Name = "xrlDate"
			Me.xrlDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrlDate.SizeF = New System.Drawing.SizeF(237.9165F, 21.24999F)
			Me.xrlDate.StylePriority.UseFont = False
			Me.xrlDate.StylePriority.UseTextAlignment = False
			Me.xrlDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 15.75F)
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(102.0833F, 0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(167.7083F, 27.49999F)
			Me.xrLabel1.StylePriority.UseFont = False
			Me.xrLabel1.Text = "Late fee receipt"
			' 
			' xrlReceiptNumber
			' 
			Me.xrlReceiptNumber.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 15.75F)
			Me.xrlReceiptNumber.LocationFloat = New DevExpress.Utils.PointFloat(269.7917F, 0F)
			Me.xrlReceiptNumber.Name = "xrlReceiptNumber"
			Me.xrlReceiptNumber.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrlReceiptNumber.SizeF = New System.Drawing.SizeF(132.2917F, 27.49999F)
			Me.xrlReceiptNumber.StylePriority.UseFont = False
			Me.xrlReceiptNumber.Text = "00000000"
			' 
			' xrTable2
			' 
			Me.xrTable2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(225))))))
			Me.xrTable2.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(160))))), (CInt(Fix((CByte(172))))), (CInt(Fix((CByte(182))))))
			Me.xrTable2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrTable2.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 9.75F)
			Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(28.12497F, 113.9583F)
			Me.xrTable2.Name = "xrTable2"
			Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow2})
			Me.xrTable2.SizeF = New System.Drawing.SizeF(611.875F, 25F)
			Me.xrTable2.StylePriority.UseBackColor = False
			Me.xrTable2.StylePriority.UseBorderColor = False
			Me.xrTable2.StylePriority.UseBorders = False
			Me.xrTable2.StylePriority.UseFont = False
			Me.xrTable2.StylePriority.UseTextAlignment = False
			Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrTableRow2
			' 
			Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell9, Me.xrTableCell10})
			Me.xrTableRow2.Name = "xrTableRow2"
			Me.xrTableRow2.Weight = 1
			' 
			' xrTableCell7
			' 
			Me.xrTableCell7.Name = "xrTableCell7"
			Me.xrTableCell7.StylePriority.UseTextAlignment = False
			Me.xrTableCell7.Text = "#"
			Me.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell7.Weight = 0.36057717192206479
			' 
			' xrTableCell8
			' 
			Me.xrTableCell8.Name = "xrTableCell8"
			Me.xrTableCell8.StylePriority.UseTextAlignment = False
			Me.xrTableCell8.Text = "Movie"
			Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell8.Weight = 1.4158653687456737
			' 
			' xrTableCell9
			' 
			Me.xrTableCell9.Name = "xrTableCell9"
			Me.xrTableCell9.StylePriority.UseTextAlignment = False
			Me.xrTableCell9.Text = "Days Overdue"
			Me.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell9.Weight = 0.44831735949544194
			' 
			' xrTableCell10
			' 
			Me.xrTableCell10.Name = "xrTableCell10"
			Me.xrTableCell10.StylePriority.UseTextAlignment = False
			Me.xrTableCell10.Text = "Payment Due"
			Me.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
			Me.xrTableCell10.Weight = 0.59927756635922091
			' 
			' xpRents
			' 
			Me.xpRents.LoadingEnabled = False
			Me.xpRents.ObjectType = GetType(DevExpress.VideoRent.Rent)
			' 
			' ReportFooter
			' 
			Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrLabel7, Me.xrlPayment, Me.xrLabel5, Me.xrlDiscount, Me.xrLabel3, Me.xrLabel2})
			Me.ReportFooter.Name = "ReportFooter"
			' 
			' xrLine1
			' 
			Me.xrLine1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(160))))), (CInt(Fix((CByte(172))))), (CInt(Fix((CByte(182))))))
			Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(396.3546F, 56.49999F)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.SizeF = New System.Drawing.SizeF(243.6454F, 12.99998F)
			Me.xrLine1.StylePriority.UseBorderColor = False
			Me.xrLine1.StylePriority.UseForeColor = False
			' 
			' xrLabel7
			' 
			Me.xrLabel7.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 12F)
			Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(396.3545F, 69.49998F)
			Me.xrLabel7.Name = "xrLabel7"
			Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel7.SizeF = New System.Drawing.SizeF(113.8021F, 21.24999F)
			Me.xrLabel7.StylePriority.UseFont = False
			Me.xrLabel7.Text = "Invoice Total:"
			' 
			' xrlPayment
			' 
			Me.xrlPayment.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 12F)
			Me.xrlPayment.LocationFloat = New DevExpress.Utils.PointFloat(510.1566F, 69.49998F)
			Me.xrlPayment.Name = "xrlPayment"
			Me.xrlPayment.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrlPayment.SizeF = New System.Drawing.SizeF(129.8434F, 21.24999F)
			Me.xrlPayment.StylePriority.UseFont = False
			Me.xrlPayment.StylePriority.UseTextAlignment = False
			xrSummary2.FormatString = "{0:$0.00}"
			Me.xrlPayment.Summary = xrSummary2
			Me.xrlPayment.Text = "0"
			Me.xrlPayment.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' xrLabel5
			' 
			Me.xrLabel5.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 11.25F)
			Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(396.3545F, 35.25F)
			Me.xrLabel5.Name = "xrLabel5"
			Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel5.SizeF = New System.Drawing.SizeF(113.8019F, 21.24999F)
			Me.xrLabel5.StylePriority.UseFont = False
			Me.xrLabel5.Text = "Discount:"
			' 
			' xrlDiscount
			' 
			Me.xrlDiscount.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 11.25F)
			Me.xrlDiscount.LocationFloat = New DevExpress.Utils.PointFloat(510.1566F, 35.25F)
			Me.xrlDiscount.Name = "xrlDiscount"
			Me.xrlDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrlDiscount.SizeF = New System.Drawing.SizeF(129.8434F, 21.24999F)
			Me.xrlDiscount.StylePriority.UseFont = False
			Me.xrlDiscount.StylePriority.UseTextAlignment = False
			xrSummary3.FormatString = "{0:$0.00}"
			Me.xrlDiscount.Summary = xrSummary3
			Me.xrlDiscount.Text = "0"
			Me.xrlDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' xrLabel3
			' 
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "OverduePayment")})
			Me.xrLabel3.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 11.25F)
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(510.1564F, 10.00001F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(129.8436F, 21.24999F)
			Me.xrLabel3.StylePriority.UseFont = False
			Me.xrLabel3.StylePriority.UseTextAlignment = False
			xrSummary4.FormatString = "{0:c}"
			xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
			Me.xrLabel3.Summary = xrSummary4
			Me.xrLabel3.Text = "xrLabel3"
			Me.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' xrLabel2
			' 
			Me.xrLabel2.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 11.25F)
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(396.3543F, 10.00001F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(113.8021F, 21.24999F)
			Me.xrLabel2.StylePriority.UseFont = False
			Me.xrLabel2.Text = "Sub Total:"
			' 
			' LatefeeReceipt
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.topMarginBand1, Me.detailBand1, Me.bottomMarginBand1, Me.ReportHeader, Me.ReportFooter})
			Me.DataSource = Me.xpRents
			Me.Version = "10.2"
			CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpRents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
		Private detailBand1 As DevExpress.XtraReports.UI.DetailBand
		Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrlReceiptNumber As DevExpress.XtraReports.UI.XRLabel
		Private xrTable1 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
		Private xpRents As DevExpress.Xpo.XPCollection
		Private xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTable2 As DevExpress.XtraReports.UI.XRTable
		Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
		Private xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
		Private xrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
		Private ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
		Private xrlPayment As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
		Private xrlDiscount As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrlDate As DevExpress.XtraReports.UI.XRLabel
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
		Private xrlCustomerName As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
		Private xrlCustomerPhone As DevExpress.XtraReports.UI.XRLabel
		Private xrlCustomerAddress As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
